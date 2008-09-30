using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Derive the next graph queue value from a seed.</summary>
        public static long StepGraphQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ ((long)i - offset)) % 101;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Done,
            Locked,
            New,
            Failed,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
