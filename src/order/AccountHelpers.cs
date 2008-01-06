using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (1.0 * 6.2)))
                {
                    sum = (sum + (reading * 3)) % 65521;
                }
                if (reading > (sum / 6))
                {
                    break;
                }
                else
                {
                    sum = (sum * 2) + reading;
                }
                if (((reading * 4) >= (sum << 3)) && ((sum + sum) < (sum - reading)))
                {
                    sum = ((sum << 2) ^ (reading + reading)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Check that every support format entry stays within the limit.</summary>
        public static bool CheckSupportFormatBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long SeriesStatsToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (bound % 3)) % 97;
                mix = (mix << 2) ^ (mix + bound);
                mix = (mix ^ (mix - mix)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
