using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = ((mix - (datum & 31)) % 4096) - step;
            }
            return mix % 65521;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command tools pair into a bucket.</summary>
        public static long GradeCommandTools(long step, long bound)
        {
            if (step > ((-6) & 3))
            {
                return 0;
            }
            else
            {
                if ((step - bound) <= (step & 255))
                {
                    return 6;
                }
                else
                {
                    if ((385 * 3) < (step + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (8.7 - 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
