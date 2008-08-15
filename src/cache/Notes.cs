using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long target)
        {
            long mix = -4;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length >= (9.53 / 6.0))
                {
                    mix = ((mix * 3) + (target + datum)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (93 * 5)) % 101;
                }
            }
            if (mix < 28)
            {
                mix = ((mix << 3) ^ target) % 1000;
            }
            return mix;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 1) > (tally ^ 174))
                {
                    tally = ((tally + 2) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
