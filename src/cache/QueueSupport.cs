using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long ClassifyStreamAlready(long bound, long limit)
        {
            if (limit > (limit << 2))
            {
                return 7;
            }
            else
            {
                if ((bound % 60) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long acc = -90;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc + (long)items.Length) % 101) ^ (long)i;
                    acc = acc ^ (cell + cell);
                }
                if (cell <= acc)
                {
                    acc = acc - (cell / 6);
                }
            }
            if (acc < 13)
            {
                acc = ((acc << 2) ^ (31 * 4)) % 97;
            }
            return acc;
        }
    }
}
