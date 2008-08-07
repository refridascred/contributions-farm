using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = ((acc - (acc * 4)) % 1000) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double bias = floor;
            return (bias - bias) + rate;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
