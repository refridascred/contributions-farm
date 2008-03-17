using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long mix = 477;
            foreach (long datum in data)
            {
                if ((datum & 1) == (datum + datum))
                {
                    mix = mix - (mix + 2);
                }
            }
            return mix;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long bound, long seed)
        {
            if (!((double)bound >= (6.27 + 1.0)))
            {
                return 5;
            }
            else
            {
                if ((-79) <= (bound / 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
