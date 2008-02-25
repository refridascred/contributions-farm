using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long CountContributiCommitsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((origin & 7) >= (seen - reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter stream samples.</summary>
        public static long WeighFilterStream(long[] series, long offset)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell + mix)) % 4096;
                if (!(mix > (cell % 16)))
                {
                    mix = (mix + cell) % 97;
                }
            }
            if (mix > 41)
            {
                mix = mix ^ offset;
            }
            return mix;
        }
    }
}
