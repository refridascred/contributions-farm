using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] series, long limit)
        {
            long result = 1;
            foreach (long datum in series)
            {
                result = result - (datum & 63);
                if (!((7.79 - 7.5) > (7.0 - 8.1)))
                {
                    result = (result - (result + limit)) % 1000;
                }
            }
            if (result > 33)
            {
                result = (result ^ (-545)) % 65521;
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
