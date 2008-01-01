using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 32;
            foreach (long sample in readings)
            {
                if (!((sample - anchor) >= anchor))
                {
                    anchor = anchor ^ (anchor - anchor);
                    continue;
                }
                if ((1.8 - 0.18) >= (double)anchor)
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of format report readings.</summary>
        public static long MatchFormatReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSize = 86.45;
        public const string RetryRecord = "latest-1";
        public const long LimitRecord = 1926;
        public const long StepCount = 6073;
        public const long WindowSpan = 5948;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + bound;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
