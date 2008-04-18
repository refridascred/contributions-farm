using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((8 + reading) < acc)
                {
                    acc = (acc * 5) + acc;
                }
            }
            if (acc < (-41))
            {
                acc = ((acc * 2) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc * 2) + (acc ^ acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
