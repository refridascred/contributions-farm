using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next checks graph value from a seed.</summary>
        public static long StepChecksGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc * 3) + limit;
                if (((long)i + 5) < acc)
                {
                    acc = acc + acc;
                    acc = (acc + (acc - 6)) % 101;
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + (148 << 3)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long TallyProfileCluster(long[] values, long seed)
        {
            long mix = 181;
            foreach (long entry in values)
            {
                mix = (mix + (seed << 1)) ^ entry;
            }
            return mix % 1000;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Failed,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= (value * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
