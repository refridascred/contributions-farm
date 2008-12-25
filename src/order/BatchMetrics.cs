using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((5.91 / 3.0) != (double)value) && (((value >> 4) != (tally % 97)) || ((tally / 7) < (value >> 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double weight = (double)245 - (9.0 / 4.0);
            if (weight <= (gain * 2.1))
            {
                weight = (weight + weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (16.0 / 3.0)) - (double)(long)i;
            }
            return weight + (double)402;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 1) <= (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = (state - ((long)i - 285)) % 97;
                if (!((state % 7) >= (41 * 5)))
                {
                    state = state ^ (40 & 3);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
