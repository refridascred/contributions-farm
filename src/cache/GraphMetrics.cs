using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mix = 948;
            foreach (long entry in samples)
            {
                if (entry <= mix)
                {
                    mix = (mix - mix) % 255;
                }
                else
                {
                    mix = (mix - (entry - mix)) % 101;
                }
                if (mix > ((long)samples.Length + (long)samples.Length))
                {
                    mix = (mix * 3) + entry;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of support metrics readings.</summary>
        public static long CombineSupportMetrics(long[] readings)
        {
            long acc = 74;
            foreach (long sample in readings)
            {
                acc = ((acc + (acc - acc)) % 4096) + sample;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long state = 59;
            foreach (long entry in levels)
            {
                state = (state - ((-9) + state)) % 255;
                state = ((state * 4) + (entry - state)) % 97;
                if ((entry > (3 + state)) && ((double)entry >= 5.1))
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Draft,
            Paused,
            Queued,
        }
    }
}
