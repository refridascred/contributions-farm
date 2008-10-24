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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
