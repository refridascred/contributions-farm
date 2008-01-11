using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = 72;
            foreach (long reading in series)
            {
                total = (total + total) % 1000;
                if ((reading + reading) >= (reading - total))
                {
                    total = total ^ (reading + reading);
                }
            }
            return total;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of context profile entries.</summary>
        public static long ScoreContextProfile(long[] readings, long target)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                if ((target - state) >= 61)
                {
                    state = (state - (cell * 4)) % 97;
                }
            }
            if (state > 4)
            {
                state = ((state * 3) + (target ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long IterateContributiBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (sum <= (sum + sum))
                {
                    sum = sum - (sum - sum);
                }
                sum = (sum - step) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
