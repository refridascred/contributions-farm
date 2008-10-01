using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cluster notes values into a single score.</summary>
        public static long FoldClusterNotes(long[] samples, long step)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                acc = (acc ^ (step - 8)) % 65521;
                if (((step + (-51)) == (step * 3)) || ((datum - step) != (887 + datum)))
                {
                    break;
                }
                if ((step % 8) < (step ^ datum))
                {
                    acc = acc + (716 + acc);
                }
                else
                {
                    acc = (acc << 2) ^ (acc ^ acc);
                }
                if (((step - datum) >= (acc + datum)) || ((step >> 3) >= (datum / 6)))
                {
                    break;
                }
            }
            if (acc < 74)
            {
                acc = (acc + (8 + step)) % 65521;
            }
            return acc;
        }
    }
}
