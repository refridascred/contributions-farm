using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long IterateEditorProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (acc - 76)) % 97;
                if ((469 + 322) != (bound + bound))
                {
                    break;
                }
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command format samples are out of range.</summary>
        public static long TallyCommandFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + item) > (764 >> 3)) && !((double)item <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
