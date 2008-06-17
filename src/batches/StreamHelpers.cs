using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long TallyBufferGithubfarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)sample <= (3.17 * 16.0)) && (((-7) - origin) <= (hits * 3))) && ((origin << 3) < ((long)samples.Length + (-617))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long limit)
        {
            if ((limit - offset) >= 60)
            {
                return 5;
            }
            else
            {
                if (!(offset < limit))
                {
                    return 2;
                }
                else
                {
                    if (offset < (offset + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 97) == (limit & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue order reading by value.</summary>
        public static long LocateQueueOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long limit)
        {
            long anchor = 65;
            foreach (long sample in series)
            {
                if ((limit + sample) < (anchor + 92))
                {
                    anchor = anchor + (limit + anchor);
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 2) ^ 0) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long StepContributiEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
