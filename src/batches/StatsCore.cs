using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long seed)
        {
            if (!((limit << 3) >= limit))
            {
                return 8;
            }
            else
            {
                if (!((seed * 2) != (limit - limit)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long TallyNotesBatches(long[] data, long origin)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                acc = (acc - (entry - (long)data.Length)) % 97;
                if ((8.3 * 19.0) == (double)origin)
                {
                    acc = (acc - (origin - (long)data.Length)) % 101;
                    acc = (acc ^ (acc >> 1)) % 65521;
                }
                if (!(entry > (entry - entry)))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            if (acc < 8)
            {
                acc = ((acc * 2) + (origin + acc)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Failed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-8) <= (carry - floor)) && ((floor ^ 588) >= (-386)))
                {
                    carry = (carry + (carry - floor)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 255;
                }
                if (carry >= (473 ^ carry))
                {
                    carry = ((carry << 2) ^ (floor ^ 85)) % 1000;
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] items, long target)
        {
            long result = 755;
            foreach (long reading in items)
            {
                result = (((result + (7 * 5)) % 255) + reading) + target;
                if (19.0 < (double)result)
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
