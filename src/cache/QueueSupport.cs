using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if (!((step / 4) < offset2))
            {
                return 8;
            }
            else
            {
                if (((step + step) >= (step ^ 69)) || ((step ^ offset) <= offset2))
                {
                    return 1;
                }
                else
                {
                    if ((step + offset) > (step % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6279;
        public const long SoftScore = 8853;
        public const double BaseWidth = 28.75;
        public const string MaxSpan = "legacy-edge";

        /// <summary>Roll a metric batches counter forward.</summary>
        public static long DeriveMetricBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (94 % 7)) % 1000;
                state = ((state * 4) + (state + (long)i)) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
