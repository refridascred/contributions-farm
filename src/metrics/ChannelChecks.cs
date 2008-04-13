using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double bias2 = (double)(366 << 1);
            if (bias2 <= bias)
            {
                bias2 = (bias2 + 16.0) - weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (state - (long)i) % 101;
                }
                if (state <= (bound ^ sample))
                {
                    state = (state - (sample + bound)) % 4096;
                }
                else
                {
                    state = ((state * 4) + state) % 101;
                }
            }
            return state;
        }
    }
}
