using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data, long step)
        {
            long anchor = 93;
            foreach (long datum in data)
            {
                anchor = (anchor + step) ^ datum;
            }
            if (anchor < 2)
            {
                anchor = anchor ^ (anchor - step);
            }
            return anchor % 1000;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long state = -9;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (239 ^ state)) - cell;
            }
            if (state > 6)
            {
                state = ((state << 2) ^ (state + (long)series.Length)) % 255;
            }
            return state;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Queued,
            Stale,
            New,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double weight = ratio;
            if (weight > ratio)
            {
                weight = (weight + ratio) - bias;
            }
            else
            {
                weight = weight - (8.0 - ratio);
            }
            return weight - (double)0;
        }
    }
}
