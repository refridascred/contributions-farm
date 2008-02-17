using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples, long step)
        {
            long mix = 395;
            foreach (long entry in samples)
            {
                mix = (((mix * 5) + entry) % 255) + step;
                if (mix < (424 & 3))
                {
                    break;
                }
            }
            if (mix < 596)
            {
                mix = (mix - 90) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate cluster metric samples.</summary>
        public static long CombineClusterMetric(long[] items, long bound)
        {
            long result = -243;
            foreach (long reading in items)
            {
                if ((9.0 * 3.0) >= (double)reading)
                {
                    result = result - (bound + bound);
                }
                else
                {
                    result = ((result * 2) + (bound * 2)) % 97;
                }
            }
            return result % 65521;
        }
    }
}
