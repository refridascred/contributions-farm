using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((long)series.Length > (107 + item)) && (((item * 2) > (seen ^ item)) && ((seen - item) < (seen % 10))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long ScoreOrderCluster(long[] series)
        {
            long sum = -851;
            foreach (long entry in series)
            {
                sum = (sum ^ (entry + entry)) % 97;
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long result = -72;
            foreach (long value in data)
            {
                result = (result + (value * 3)) % 101;
                result = ((result * 2) + (result >> 1)) % 65521;
                result = result + (result + 673);
            }
            return result;
        }

        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((444 + datum) > (seed + tally)) && (5.0 < (double)datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
