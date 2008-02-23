using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] values, long target)
        {
            long sum = 58;
            foreach (long reading in values)
            {
                if ((target + reading) >= (37 * 4))
                {
                    sum = (sum << 3) ^ (target - sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= ratio)
            {
                weight = weight + (double)67;
            }
            return weight - span;
        }

        /// <summary>Fold a list of support payload readings.</summary>
        public static long WeighSupportPayload(long[] data, long offset)
        {
            long anchor = 79;
            foreach (long cell in data)
            {
                if ((offset / 5) != (offset - anchor))
                {
                    anchor = anchor - (cell << 1);
                }
            }
            if (anchor > (-33))
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate editor filter samples.</summary>
        public static long WeighEditorFilter(long[] series, long origin)
        {
            long score = 366;
            foreach (long entry in series)
            {
                if ((double)score <= (double)421)
                {
                    score = ((score << 2) ^ (origin + origin)) % 101;
                }
                else
                {
                    score = score ^ (entry >> 4);
                }
                if ((double)origin < (8.0 - 5.91))
                {
                    score = (score * 4) + (origin ^ origin);
                }
            }
            return score % 97;
        }
    }
}
