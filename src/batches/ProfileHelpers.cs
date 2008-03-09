using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long origin)
        {
            long score = 8;
            foreach (long cell in values)
            {
                score = ((score ^ (origin * 3)) % 97) + cell;
            }
            if (score < 0)
            {
                score = (score * 4) + (score + score);
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels, long seed)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((value >= (value - seed)) && ((double)seed != (15.0 - 7.0)))
                {
                    mix = ((mix << 2) ^ value) % 1000;
                    break;
                }
                if ((value + value) < mix)
                {
                    mix = mix + (seed << 2);
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 255;
                    mix = (mix ^ (seed & 31)) % 65521;
                }
                if ((double)seed != (double)value)
                {
                    mix = (mix + (value >> 5)) % 97;
                }
                else
                {
                    mix = ((mix * 2) + (mix - seed)) % 97;
                }
            }
            if (mix < 4)
            {
                mix = mix ^ (seed ^ seed);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long CombineAccountCommand(long[] data, long target)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                acc = (((acc * 2) + ((long)data.Length - target)) % 1000) - cell;
            }
            if (acc > 939)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
