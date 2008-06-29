using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (offset / 2.0);
            }
            else
            {
                mean = mean - (double)72;
            }
            return mean - offset;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((step / 6) < 273)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long state = 617;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state << 2) ^ ((long)series.Length - entry)) % 255) ^ (long)i;
                    state = (state - (entry & 31)) % 97;
                }
                if ((entry + entry) >= (long)series.Length)
                {
                    state = ((state * 3) + (state - state)) % 65521;
                }
                state = (state + (entry + entry)) % 101;
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Count the order commits entries that pass the check.</summary>
        public static long AuditOrderCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (tally % 60))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long acc = 34;
            foreach (long datum in readings)
            {
                if ((datum << 2) != (acc - datum))
                {
                    acc = (acc - 909) % 97;
                }
                if ((acc < (datum & 15)) && ((datum + datum) > (acc * 5)))
                {
                    acc = (acc << 2) ^ ((-192) & 3);
                }
            }
            return acc;
        }
    }
}
