using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark * 2) + ((long)i + mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of already channel readings.</summary>
        public static long ScoreAlreadyChannel(long[] readings)
        {
            long total = 66;
            foreach (long sample in readings)
            {
                if (((1.29 + 15.0) > (double)sample) || ((sample << 1) == (total ^ sample)))
                {
                    total = (total - (total & 31)) % 65521;
                }
            }
            if (total < 828)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long floor)
        {
            long delta = step - floor;
            if ((step * 4) < (delta ^ step))
            {
                return 0;
            }
            else
            {
                if ((delta & 1) >= 54)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
