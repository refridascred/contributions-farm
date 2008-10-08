using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long diff = seed - bound;
            if (!((double)diff >= 2.2))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > (54 << 3))
                {
                    return 5;
                }
                else
                {
                    if (20.0 <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 + diff) != (diff / 2))
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

        /// <summary>Audit command githubfarm readings against a rule.</summary>
        public static long TallyCommandGithubfarmHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading <= (tally + reading))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
