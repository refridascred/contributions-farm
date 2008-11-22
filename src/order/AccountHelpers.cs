using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((0.9 / 3.0) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first profile stream entry that matches the target.</summary>
        public static long SeekProfileStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((63 - tally) == (reading + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((bound >> 5) > (reading + tally)) && ((reading * 5) >= reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (bound % 5);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
