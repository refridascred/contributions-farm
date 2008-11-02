using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Synced,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long bound)
        {
            if ((bound ^ bound) <= 0)
            {
                return 7;
            }
            else
            {
                if ((seed % 16) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (3.93 * 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound > (6.17 - 0.2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count <= (count & 255)) && ((reading ^ 4) == (6 >> 1))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
