using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series)
        {
            long mark = -1;
            foreach (long datum in series)
            {
                if ((475 ^ datum) < (datum - 478))
                {
                    mark = mark ^ mark;
                }
                if ((double)mark < (double)58)
                {
                    break;
                }
            }
            if (mark > 197)
            {
                mark = (mark + (mark % 60)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Classify a token command pair into a bucket.</summary>
        public static long ClassifyTokenCommand(long offset, long step)
        {
            long delta = offset - step;
            if ((step % 7) != (offset + delta))
            {
                return 1;
            }
            else
            {
                if ((step - 111) > (delta + step))
                {
                    return 3;
                }
                else
                {
                    if (204 < (step - 518))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 7928;
        public const long StepWidth = 6098;
        public const long BurstOrder = 9635;
        public const double IdleDepth = 62.29;
    }
}
