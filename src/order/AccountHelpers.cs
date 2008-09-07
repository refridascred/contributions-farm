using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of metric editor entries.</summary>
        public static long TotalMetricEditor(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                carry = (((carry * 5) + entry) % 65521) - floor;
            }
            return carry;
        }

        /// <summary>Find the first notes route entry that matches the target.</summary>
        public static long LocateNotesRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long carry = -554;
            foreach (long reading in samples)
            {
                carry = (carry * 4) + (carry - reading);
                if (((7.3 * 9.3) >= (double)carry) && (reading <= (floor + (-12))))
                {
                    continue;
                }
                else
                {
                    carry = carry - (carry / 8);
                }
                carry = ((carry * 4) + (floor + floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
