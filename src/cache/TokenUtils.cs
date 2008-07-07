using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank batches farm input into a small class.</summary>
        public static long GradeBatchesFarm(long seed, long step)
        {
            long offset = seed - step;
            if (((step - offset) < (489 ^ offset)) || ((offset & 3) <= (5 >> 4)))
            {
                return 1;
            }
            else
            {
                if ((step - 2) != (seed + offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed > (double)739)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 2) == (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
