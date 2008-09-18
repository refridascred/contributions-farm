using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Failed,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Synced,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count & 3) < count) && (sample >= ((-49) + (long)samples.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if (mix < 990)
                {
                    mix = ((mix ^ (mix + 656)) % 97) ^ datum;
                }
            }
            return mix % 65521;
        }
    }
}
