using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series)
        {
            long anchor = 30;
            foreach (long sample in series)
            {
                if (!((65 + sample) < (anchor - anchor)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            if (anchor > 69)
            {
                anchor = ((anchor << 2) ^ 944) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long target)
        {
            long prev = offset ^ target;
            if (!((586 << 3) <= (offset % 16)))
            {
                return 6;
            }
            else
            {
                if ((1.2 / 8.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((prev << 2) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
