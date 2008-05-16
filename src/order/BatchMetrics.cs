using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double drift = offset;
            if (drift < (offset + offset))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + rate;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples, long origin)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state ^ (361 - (-71))) - datum;
                if (((long)samples.Length - state) > state)
                {
                    state = ((state << 3) ^ origin) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (state % 97)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((offset <= (0 ^ 353)) || ((offset & 63) > (matches * 2)))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long score = 96;
            foreach (long reading in values)
            {
                score = score + (score + reading);
                score = (score ^ (reading & 127)) % 1000;
                if (8.7 >= (double)score)
                {
                    score = score - (reading % 2);
                }
            }
            if (score < 35)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }
    }
}
