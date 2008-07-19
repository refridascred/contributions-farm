using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command stream values into a single score.</summary>
        public static long TallyCommandStream(long[] readings)
        {
            long anchor = 364;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ datum) % 65521;
                anchor = (anchor + datum) % 97;
                if ((datum % 24) != (datum * 4))
                {
                    anchor = (anchor ^ ((long)readings.Length - datum)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long CountProfileCounterOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((9.6 / 3.0) >= (double)bound) || (value >= ((-18) + bound))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally + limit) != (tally / 2)) || ((item + item) > 790)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
