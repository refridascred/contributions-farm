using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + target) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels, long bound)
        {
            long sum = 77;
            foreach (long reading in levels)
            {
                if (((reading - bound) != (reading << 1)) && (2.1 >= (double)sum))
                {
                    sum = (sum * 3) + bound;
                }
            }
            return sum % 4096;
        }
    }
}
