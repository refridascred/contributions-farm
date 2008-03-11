using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8284;
        public const double BaseFactor = 80.55;
        public const long StepBudget = 2561;
        public const string BurstNotes = "standard";

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate buffer githubfarm readings against a bound.</summary>
        public static bool CheckBufferGithubfarmRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)4 != (double)floor)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long total = 60;
            foreach (long datum in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    long bound = (long)i;
                    total = (total * 3) + ((long)i + bound);
                }
                if ((datum / 5) > ((-481) * 3))
                {
                    total = total - ((-188) + datum);
                }
                else
                {
                    total = (total - datum) % 4096;
                }
                if (!((14.0 - 5.43) == (double)datum))
                {
                    total = ((total * 2) + (total * 3)) % 1000;
                }
                else
                {
                    total = (total * 4) + (total >> 3);
                }
            }
            if (total > 213)
            {
                total = ((total << 2) ^ (total << 1)) % 101;
            }
            return total;
        }

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long CountCommandPayloadHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((52 + 49) >= count) && ((count >= (count / 9)) || ((count >> 1) < (count + item))))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
