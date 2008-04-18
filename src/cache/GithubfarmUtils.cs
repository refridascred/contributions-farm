using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long carry = 538;
            foreach (long value in data)
            {
                if (value <= 0)
                {
                    carry = ((carry << 2) ^ (value / 6)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long result = 2;
            foreach (long item in items)
            {
                result = ((result - (206 >> 2)) ^ item) + floor;
            }
            return result;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double bias, double span)
        {
            double load = (bias / 6.0) * 7.8;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-602)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + item) <= ((-12) * 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
