using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!!((total + (long)i) >= (total * 5)))
                {
                    total = total ^ floor;
                }
                if ((total - total) > floor)
                {
                    total = total - total;
                }
                else
                {
                    total = (total + (floor + total)) % 97;
                    total = ((total << 2) ^ floor) % 255;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine schema stream values into a single score.</summary>
        public static long CombineSchemaStream(long[] levels, long origin)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading + reading) >= 1)
                {
                    continue;
                }
                if (((double)origin >= (double)75) && ((reading + result) > (result >> 5)))
                {
                    result = (result + reading) % 65521;
                }
                if ((origin ^ result) != (origin ^ origin))
                {
                    break;
                }
            }
            return result;
        }
    }
}
