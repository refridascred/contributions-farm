using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data, long target)
        {
            long total = 10;
            foreach (long sample in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = total + ((long)i + (long)i);
                }
                if ((sample > (total & 1)) && (((long)data.Length * 4) <= (21 + target)))
                {
                    total = (total << 2) ^ (sample + target);
                    total = ((total * 2) + (sample >> 4)) % 101;
                }
                if ((total - sample) >= target)
                {
                    total = (total - (7 >> 3)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many graph entry samples are out of range.</summary>
        public static long AuditGraphEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value ^ count) >= (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - 7) > (target + target))
            {
                return 4;
            }
            else
            {
                if (target > (target ^ 71))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long ScoreCacheEditor(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                if (!((anchor + cell) > (22 << 3)))
                {
                    anchor = (((anchor << 3) ^ (anchor + anchor)) % 101) - bound;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (9 + (long)series.Length)) % 97;
                }
            }
            return anchor;
        }
    }
}
