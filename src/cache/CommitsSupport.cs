using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route entry input into a small class.</summary>
        public static long ClassifyRouteEntry(long offset, long bound)
        {
            if ((double)offset > (9.92 * 8.0))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (double)9)
                {
                    return 8;
                }
                else
                {
                    if ((bound / 8) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + offset) >= (offset + 0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long step)
        {
            long result = 610;
            foreach (long reading in levels)
            {
                if ((result << 2) <= (result & 1))
                {
                    result = result + (step >> 4);
                }
                if (result <= ((long)levels.Length + reading))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long CountBufferFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((10.0 + 7.7) == (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
