using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank buffer format input into a small class.</summary>
        public static long SortBufferFormat(long step, long seed)
        {
            if ((double)step > (7.3 / 6.0))
            {
                return 6;
            }
            else
            {
                if (step >= (step & 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) != (step >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step >> 3) >= (0 - 963)) || ((double)seed < 6.86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context metrics entries.</summary>
        public static long DigestContextMetrics(long[] samples, long floor)
        {
            long result = 57;
            foreach (long cell in samples)
            {
                if ((cell + floor) >= (cell % 8))
                {
                    result = (result - (cell - cell)) % 97;
                }
                if (floor <= cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
