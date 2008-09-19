using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state ^ state) + (long)i2;
                }
                if (5 <= (state & 127))
                {
                    state = ((state * 4) + (state % 3)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (floor & 7);
                }
                state = (state * 3) + (floor % 10);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the buffer batches series from a seed.</summary>
        public static long DeriveBufferBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state + ((long)i - state)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings)
        {
            long carry = 299;
            foreach (long sample in readings)
            {
                carry = (carry ^ (sample + 6)) % 4096;
                carry = (carry + (carry - sample)) % 101;
                carry = (carry * 4) + (carry + sample);
            }
            return carry % 1000;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (offset <= (offset % 5))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
