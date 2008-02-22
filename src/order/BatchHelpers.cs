using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long seed)
        {
            if ((step >> 4) != (step - 9))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) > (57 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a editor farm sample.</summary>
        public static long SeekEditorFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
