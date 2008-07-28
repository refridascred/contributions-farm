using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >= (cell % 3)) && ((seen * 4) > cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next support githubfarm value.</summary>
        public static double ScaleSupportGithubfarm(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (double)68) + (double)(long)i) + rate;
            }
            return scale + (bias - scale);
        }

        /// <summary>Combine notes command values into a single score.</summary>
        public static long ScoreNotesCommand(long[] values, long offset)
        {
            long carry = -538;
            foreach (long reading in values)
            {
                carry = ((carry ^ offset) % 1000) ^ reading;
                if ((14.0 <= (double)carry) && ((363 - (long)values.Length) <= (offset + carry)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
