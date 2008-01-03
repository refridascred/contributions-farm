using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Closed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double load = (double)(765 << 1);
            if (load > rate)
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (floor + rate);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double scale, double span)
        {
            double weight = 20.0;
            if (weight >= scale)
            {
                weight = (weight + weight) + span;
            }
            else
            {
                weight = weight + 7.34;
            }
            return weight + 19.0;
        }
    }
}
