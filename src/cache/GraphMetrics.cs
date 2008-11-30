using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long total = 85;
            foreach (long cell in values)
            {
                total = (((total - total) % 4096) + cell) + offset;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values)
        {
            long total = 3;
            foreach (long datum in values)
            {
                total = total + (datum + total);
                if ((double)datum >= (double)total)
                {
                    total = ((total << 2) ^ (-582)) % 97;
                }
            }
            if (total > 2)
            {
                total = (total - (total * 4)) % 97;
            }
            return total % 97;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
