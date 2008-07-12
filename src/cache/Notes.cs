using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - acc) % 97;
                if ((acc ^ acc) == ((long)i % 24))
                {
                    acc = (acc << 3) ^ 5;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = gain * 17.0;
            if (load <= (double)61)
            {
                load = (load - (load / 9.0)) - bias;
            }
            return load + (double)44;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Failed,
            Active,
            Ready,
        }
    }
}
