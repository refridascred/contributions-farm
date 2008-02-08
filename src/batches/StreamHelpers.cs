using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((state ^ entry) != (7 - 712))
                {
                    state = state + state;
                }
                else
                {
                    state = ((state * 2) + (entry + 4)) % 4096;
                }
                if ((double)state != (double)(-27))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = (state * 4) + 38;
            }
            return state % 65521;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double scale = weight;
            if (scale <= (double)(-96))
            {
                scale = (scale - (double)5) - floor;
            }
            return scale + 19.0;
        }

        /// <summary>Accumulate farm metrics samples.</summary>
        public static long ScoreFarmMetrics(long[] values, long origin)
        {
            long acc = -2;
            foreach (long reading in values)
            {
                if (((18.0 + 5.0) <= (double)origin) && ((9.4 * 10.0) != (double)origin))
                {
                    acc = (acc ^ (119 + origin)) ^ reading;
                }
            }
            if (acc > (-216))
            {
                acc = (acc ^ (acc + origin)) % 101;
            }
            return acc;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double mean = 12.0;
            if (mean >= ratio)
            {
                mean = (mean - ratio) - floor;
            }
            return mean - 2.0;
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
