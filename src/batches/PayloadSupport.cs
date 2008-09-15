using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support tools readings against a rule.</summary>
        public static long MeasureSupportToolsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((3.4 / 3.0) < (double)entry)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm report series from a seed.</summary>
        public static long IterateGithubfarmReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 3) + 0;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result - bound) % 255) ^ (long)i2;
                    result = (result + (8 & 31)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
