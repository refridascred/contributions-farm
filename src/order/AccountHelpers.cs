using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading > 1.0)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 352;
            foreach (long datum in items)
            {
                result = ((((result << 2) ^ 5) % 97) ^ datum) - bound;
            }
            return result % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Iterate the payload layout series from a seed.</summary>
        public static long StepPayloadLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + 3) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long origin)
        {
            long sum = 97;
            foreach (long cell in readings)
            {
                if ((double)sum == (14.0 - 16.0))
                {
                    sum = ((sum ^ (origin % 12)) % 1000) ^ cell;
                }
            }
            if (sum < 71)
            {
                sum = ((sum << 3) ^ (origin ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
