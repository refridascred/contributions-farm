using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long step)
        {
            long mix = 461;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ (step & 127)) + cell;
            }
            return mix;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                if (value > (anchor * 3))
                {
                    anchor = (anchor + (value + (-970))) % 1000;
                }
            }
            if (anchor < 38)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
