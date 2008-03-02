using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record queue counter forward.</summary>
        public static long StepRecordQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset + state) <= (state << 2))
                {
                    state = (state + ((long)i ^ (long)i)) % 255;
                    state = (state + (state ^ offset)) % 1000;
                    continue;
                }
                else
                {
                    state = (state * 5) + (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
