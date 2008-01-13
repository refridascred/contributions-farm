using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches << 3) >= matches) && (cell <= (cell + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long CombineAlreadyFarm(long[] data, long step)
        {
            long sum = -3;
            foreach (long datum in data)
            {
                if (!((datum / 5) != (step + sum)))
                {
                    sum = (sum - (datum + sum)) % 97;
                }
            }
            if (sum > (-989))
            {
                sum = sum - step;
            }
            return sum;
        }
    }
}
