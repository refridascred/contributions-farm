using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long result = -874;
            foreach (long sample in readings)
            {
                if (((result / 7) >= result) && ((double)sample >= 9.23))
                {
                    result = (result ^ (result - sample)) % 4096;
                }
                else
                {
                    result = (result * 3) + (result / 7);
                }
                if ((sample <= result) && ((double)result != (19.0 + 7.46)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long bound)
        {
            long delta = step ^ bound;
            if (((582 << 3) >= bound) || ((step * 4) < (198 + delta)))
            {
                return 1;
            }
            else
            {
                if (2.82 <= (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((step & 7) != (bound - 27))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
