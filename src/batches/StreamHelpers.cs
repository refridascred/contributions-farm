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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) != (sample * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
