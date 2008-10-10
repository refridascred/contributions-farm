using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long seed)
        {
            long state = 26;
            foreach (long reading in series)
            {
                if ((reading - reading) > (seed & 15))
                {
                    state = (state * 5) + seed;
                }
                else
                {
                    state = (state ^ (reading % 24)) % 97;
                }
            }
            if (state > 0)
            {
                state = (state + (seed >> 4)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long mix = -297;
            foreach (long datum in data)
            {
                mix = (((mix * 5) + (mix & 15)) % 65521) + datum;
            }
            if (mix < 737)
            {
                mix = (mix ^ (44 ^ mix)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long MeasureAccountProfileMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) >= (seed / 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
