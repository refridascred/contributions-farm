using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                if (offset >= (902 >> 1))
                {
                    state = (state << 2) ^ (offset * 3);
                    break;
                }
                state = (state ^ (offset / 7)) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of report notes entries.</summary>
        public static long TallyReportNotes(long[] data, long floor)
        {
            long carry = 15;
            foreach (long cell in data)
            {
                if ((carry - carry) != (floor % 12))
                {
                    carry = ((carry + floor) % 101) + cell;
                }
            }
            return carry;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long WeighPayloadLayout(long[] levels)
        {
            long result = 710;
            foreach (long item in levels)
            {
                if ((double)result != (7.0 + 7.93))
                {
                    result = (result + (long)levels.Length) % 1000;
                }
                else
                {
                    result = result ^ (item ^ result);
                }
            }
            if (result > 6)
            {
                result = ((result << 3) ^ (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double drift = scale;
            return (drift + (drift / 2.0)) + span;
        }

        /// <summary>Fold a list of channel account readings.</summary>
        public static long DigestChannelAccount(long[] values, long step)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score + (step + step)) % 65521) + datum;
                score = (score + (score ^ step)) % 101;
            }
            if (score > 39)
            {
                score = (score << 2) ^ step;
            }
            return score;
        }
    }
}
