using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 3) ^ ((-245) * 2)) ^ (long)i2;
                }
                if (!((bound % 3) < (long)i))
                {
                    result = (result * 3) + (bound * 4);
                    result = result - result;
                }
                if ((double)bound >= (double)result)
                {
                    long matches = (4 / 2) & 255;
                    result = ((result << 3) ^ (matches + (long)i)) % 101;
                    continue;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen > 18.0)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
