using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine githubfarm counter values into a single score.</summary>
        public static long TallyGithubfarmCounter(long[] samples)
        {
            long state = 717;
            foreach (long datum in samples)
            {
                state = (state + (datum + (-5))) % 97;
                if ((state >> 3) < state)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                mix = ((mix + mix) % 97) + item;
            }
            return mix % 4096;
        }
    }
}
